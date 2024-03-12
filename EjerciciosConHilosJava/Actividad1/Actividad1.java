package Actividad1;
public class Actividad1 {
    public static void main(String[] args) {
        AumentoNumero aumento = new AumentoNumero(1, 100);
        DisminucionNumero disminucion = new DisminucionNumero(100, 1);

        Thread hiloAumento = new Thread(aumento);
        Thread hiloDisminucion = new Thread(disminucion);

        hiloAumento.start();
        hiloDisminucion.start();
    }
}

