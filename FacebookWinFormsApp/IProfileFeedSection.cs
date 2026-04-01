namespace BasicFacebookFeatures
{
    public interface IProfileFeedSection
    {
        bool Load();

        object DataSource { get; }
        string DisplayMember { get; }
    }
}