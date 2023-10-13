using Chapter12.Models;

namespace Chapter12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContentRepositoryProxy contentRepositoryProxy =
                new ContentRepositoryProxy(DeviceType.Web);

            var contentListForWeb = contentRepositoryProxy.GetContent();

            Console.WriteLine("Web: " + contentListForWeb.Count + ". Has ads:" + 
                contentListForWeb.Any(x=> x.Advertisements.Count > 0));

            contentRepositoryProxy =
                new ContentRepositoryProxy(DeviceType.Desktop);

            var contentListForDesktop = contentRepositoryProxy.GetContent();

            Console.WriteLine("Desktop: " + contentListForDesktop.Count + ". Has ads:" +
                contentListForDesktop.Any(x => x.Advertisements.Count > 0));

            contentRepositoryProxy =
                new ContentRepositoryProxy(DeviceType.Mobile);

            var contentListForMobile = contentRepositoryProxy.GetContent();

            Console.WriteLine("Mobile: " + contentListForMobile.Count + ". Has ads:" +
                contentListForMobile.Any(x => x.Advertisements.Count > 0));

        }
    }
}