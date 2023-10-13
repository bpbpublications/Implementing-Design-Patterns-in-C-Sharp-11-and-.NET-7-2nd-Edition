namespace Chapter12.Models
{
    public class ContentRepositoryProxy : IContentRepository
    {
        private DeviceType _deviceType;
        ContentRepository contentRepository = new ContentRepository();

        public ContentRepositoryProxy(DeviceType deviceType)
        {
            _deviceType = deviceType;
        }

        public List<Content> GetContent()
        {
            List<Content> contentList = contentRepository.GetContent();

            switch (_deviceType)
            {
                case DeviceType.Mobile:
                    contentList.ForEach(x => { x.Advertisements = new List<Advertisement>(); });
                    break;
                case DeviceType.Web:
                    contentList = contentList.Where(x => x.Category != CategoryEnum.Lifestyle).ToList();
                    break;
            }

            return contentList;
        }
    }

    public enum DeviceType
    {
        Desktop = 1,
        Mobile = 2,
        Web = 3
    }
}



