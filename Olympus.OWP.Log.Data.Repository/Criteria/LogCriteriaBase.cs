using Fanex.Data.Repository;

namespace Olympus.OWP.Log.Data.Repository.Criteria
{
    public abstract class LogCriteriaBase : INonQueryCommand
    {
        public DateTime CreatedDate { get; set; }

        public string Action { get; set; }

        public string Payload { get; set; }

        public abstract string GetSettingKey();

        public virtual bool IsValid() => !string.IsNullOrWhiteSpace(Action);



    }
}
