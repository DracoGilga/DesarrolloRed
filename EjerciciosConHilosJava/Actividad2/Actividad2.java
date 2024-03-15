package Actividad2;

public class Actividad2 {
    public static void main(String[] args) {
        Saludo saludo1 = new Saludo("Hola ");
        Saludo saludo2 = new Saludo("Mundo \n");

        Thread hiloSaludo1 = new Thread(saludo1);
        Thread hiloSaludo2 = new Thread(saludo2);

        hiloSaludo1.start();
        hiloSaludo2.start();
    }
}