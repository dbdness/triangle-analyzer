package dk.dbd;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        double side1, side2, side3;

        System.out.println("Welcome!");
        while (true) {
            System.out.println("Please enter the length of the first side of the triangle:");
            try {
                side1 = input.nextDouble();
                break;
            } catch (InputMismatchException ex) {
                System.out.println("Wrong value - you can only enter numerical values. Please enter an integer or a decimal value");
                input.next();
            }
        }
        while (true) {
            System.out.println("Please enter the length of the second side of the triangle:");
            try {
                side2 = input.nextDouble();
                break;
            } catch (InputMismatchException ex) {
                System.out.println("Wrong value - you can only enter numerical values. Please enter an integer or a decimal value");
                input.next();
            }
        }
        while (true) {
            System.out.println("Please enter the length of the third side of the triangle:");
            try {
                side3 = input.nextDouble();
                break;
            } catch (InputMismatchException ex) {
                System.out.println("Wrong value - you can only enter numerical values. Please enter an integer or a decimal value");
                input.next();
            }
        }

        Triangle triangle = new Triangle(side1, side2, side3);
        String type = triangle.getType();

        switch (type) {
            case "Equilateral":
                System.out.println("Your triangle is equilateral! All three of its sides are of equal length.");
                break;
            case "Isosceles":
                System.out.println("Your triangle is isosceles! Two of its sides are of equal length.");
                break;
            case "Scalene":
                System.out.println("Your triangle is scalene! None of its sides are of equal length.");
                break;
            default:
                System.out.println(type);
                break;
        }


    }
}
