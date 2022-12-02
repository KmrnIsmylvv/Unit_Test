namespace TestNinja.Mocking;

public class FakeFileReader : IFileReader
{
    public string Read(string path)
    {
        return "";
    }
}