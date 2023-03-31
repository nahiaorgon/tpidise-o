namespace Reciplas.Models;

public class Appointment : EntidadBase{
    public DateTime Start {get; set;}
    public DateTime End {get; set;}
    public String Text {get; set;}

}