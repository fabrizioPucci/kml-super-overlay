using System;
using System.Collections.Generic;
using System.Text;
using KMLib;

namespace KmlSuperOverlay
{
    public class KmlTiler
    {
        public void TEST_MakeKML(string fpath) {
            double n = 37.430419921875;
            double s = 37.41943359375;
            double e = -122.091064453125;
            double w = -122.10205078125;
            MakeKML(new LatLonBox(n, s, e, w));
            kmlDoc.Save(fpath);
        }

        KmlDocument kmlDoc;
        KMLRoot kml;
        private ALatLonBox latLonBox;
        public void MakeKML(ALatLonBox llb) {
            latLonBox = llb;
            kmlDoc = new KmlDocument();
            kml = new KMLRoot();
            kmlDoc.KML = kml;
            AddMainRegion();
            AddGroundOverlay("foo.jpg");
            AddSubRegion(GetLatLonBox(1, 2, 1, 2), "foo11.kml");
            AddSubRegion(GetLatLonBox(2, 2, 1, 2), "foo21.kml");
            AddSubRegion(GetLatLonBox(1, 2, 2, 2), "foo12.kml");
            AddSubRegion(GetLatLonBox(2, 2, 2, 2), "foo22.kml");
        }

        private ALatLonBox GetLatLonBox(int x, int nx, int y, int ny) {
            double w = latLonBox.east - latLonBox.west;
            double h = latLonBox.north - latLonBox.south;

            double tw = w / (double)nx;
            double th = h / (double)ny;

            double wst = latLonBox.east;
            double sth = latLonBox.south;

            return new LatLonBox(sth + (y - 1) * th, sth + y * th, wst + (x - 1) * tw, wst + x * tw);
        }

        private void AddSubRegion(ALatLonBox sub_llb, string href) {
            NetworkLink nlink = new NetworkLink();
            nlink.Region.Lod.minLodPixels = 128;
            nlink.Region.LatLonAltBox = new LatLonAltBox(sub_llb);
            nlink.Link.href = href;
            nlink.Link.viewRefreshMode = ViewRefreshMode.onRegion;
            kml.Add(nlink);
        }

        private void AddMainRegion() {
            Region region = new Region();
            kml.Add(region);
            region.Lod.minLodPixels = 128;
            region.LatLonAltBox = new LatLonAltBox(latLonBox);
        }

        private void AddGroundOverlay(string jpgHref) {
            GroundOverlay g = new GroundOverlay();
            kml.Add(g);
            g.drawOrder = 5;
            g.Icon.href = jpgHref;            
            g.LatLonBox = new LatLonBox(latLonBox);
        }

        /*
         <GroundOverlay>
      <drawOrder>5</drawOrder>
      <Icon>
        <href>179.JPEG</href>
      </Icon>
      <LatLonBox>
        <north>37.430419921875</north><south>37.41943359375</south>
        <east>-122.091064453125</east><west>-122.10205078125</west>
      </LatLonBox>
    </GroundOverlay>
         */
    }
}
