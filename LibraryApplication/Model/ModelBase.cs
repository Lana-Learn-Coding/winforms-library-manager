namespace WinFormsLibraryManager.Model
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }
    }

    public interface INamed
    {
        string Name { get; set; }
    }
}