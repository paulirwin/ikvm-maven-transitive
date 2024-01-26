using org.apache.commons.configuration2;

namespace PackageC;

public static class TestC
{
    public static void Test()
    {
        var config = new PropertiesConfiguration();
        config.addProperty("key", "value");
        var value = config.getString("key");
        Console.WriteLine(value);
    }
}
