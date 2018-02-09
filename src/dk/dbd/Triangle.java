package dk.dbd;

public class Triangle {
    private double side1;
    private double side2;
    private double side3;
    private Type type;

    public enum Type {
        Equilateral,
        Isosceles,
        Scalene

    }

    public Triangle(double side1, double side2, double side3){
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public String getType(){
        String type = "Couldn't calculate type."; //If none of the below criteria are met (for some reason), returns error.
        if(side1 == side2 && side1 == side3 && side2 == side3){
            type = Type.Equilateral.name();
            return type;
        }
        if(side1 == side2 || side1 == side3 || side2 == side3){
            type = Type.Isosceles.name();
            return type;
        }
        if(side1 != side2 && side1 != side3){
            type = Type.Scalene.name();
            return type;
        }
        return type;
    }
}
