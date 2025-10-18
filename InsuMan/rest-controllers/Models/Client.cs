namespace rest_controllers.Models
{
    public class Client: EntityWithId
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Address { get; set; }

        //public int TemperatureC { get; set; }

        //public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //public string? Summary { get; set; }
    }
}
