using rest_controllers.Types;

namespace rest_controllers.Models
{
    public class Insurance: EntityWithId
    {
        public string Description { get; set; }
        public InsuranceTypeEnum Type { get; set; }
    }
}
