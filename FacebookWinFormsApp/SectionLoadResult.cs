using System;

namespace BasicFacebookFeatures
{
    public class SectionLoadResult
    {
        public bool HasData { get; }
        public object DataSource { get; }
        public string DisplayMember { get; }
        public string StrategyName { get; }

        public SectionLoadResult(bool i_HasData, object i_DataSource, string i_DisplayMember, string i_StrategyName)
        {
            HasData = i_HasData;
            DataSource = i_DataSource;
            DisplayMember = i_DisplayMember;
            StrategyName = i_StrategyName;
        }
    }
}
