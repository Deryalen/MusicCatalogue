namespace MusicCatalogue.Model
{
    using System;

    public class ModelBase
    {
        private DateTime createTimeStamp;

        private DateTime updateTimeStamp;

        public DateTime CreateTimeStamp
        {
            get
            {
                return createTimeStamp;
            }
            set
            {
                if (createTimeStamp != value)
                {
                    createTimeStamp = value;
                }
            }
        }

        public DateTime UpdateTimeStamp
        {
            get
            {
                return updateTimeStamp;
            }
            set
            {
                if (updateTimeStamp != value)
                {
                    updateTimeStamp = value;
                }
            }
        }
    }
}
