namespace Datamesh.Data.Dto
{
    public class DataDomainDto

    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string NameAbbreviationShort { get; set; }
        public string NameAbbreviationLong { get; set; }
        public string SubscriptionName { get; set; }
        public Guid SubscriptionId { get; set; }
        public string DevOpsProjectName { get; set; }
    }
}