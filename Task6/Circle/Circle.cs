public class Circle{
    double radius;
    const double pi=3.14;
     public Circle(double radius){
        this.radius=radius;
     }

     public double GetArea(){
        return pi*radius*radius;
     }
     public double GetDiameter(){
        return 2*radius;
     }
     public double GetCircumference(){
        return 2*pi*radius;
     }
     public double GetRadius(){
        return radius;
     }

}