namespace APIteste.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public int numberOfPointsOfInterest 
        { 
            get 
            { 
                return PointsOfInterest.Count; 
            } 
        }
        public ICollection<PointsOfInterestDto> PointsOfInterest { get; set; }
                = new List<PointsOfInterestDto>();
       
    }
}
