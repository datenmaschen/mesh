using Datamesh.Models;

namespace datamesh_api.Tests;
public class DataDomainUnitTest
{
    [Fact]
    private static DataDomain CreateTestDataDomain()
    {
        return new DataDomain()
        {
            Key = "Mesh",
            Name = "DataMesh",
            SubscriptionName = "datenmaschen-chn-1",
            DevOpsProjectName = "Datenmaschen",
            NameAbbreviationLong = "dmsh",
            NameAbbreviationShort = "dm",
        };
    }
}