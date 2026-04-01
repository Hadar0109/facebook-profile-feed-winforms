using System;

namespace BasicFacebookFeatures
{
    public class FeedContext
    {
        public IProfileFeedSection Strategy { get; set; }

        public FeedContext(IProfileFeedSection i_Strategy)
        {
            Strategy = i_Strategy;
        }

        public SectionLoadResult LoadCurrentSection()
        {
            if (Strategy == null)
            {
                throw new InvalidOperationException("Strategy was not set.");
            }

            bool hasData = Strategy.Load();

            return new SectionLoadResult(hasData, Strategy.DataSource, Strategy.DisplayMember, Strategy.GetType().Name);
        }
    }
}
