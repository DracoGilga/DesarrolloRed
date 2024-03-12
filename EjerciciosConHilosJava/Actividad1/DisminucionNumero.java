package Actividad1;

public class DisminucionNumero implements Runnable{
    private int numeroEntrada;
    private int numeroLimite;
    private long latencia;

    public DisminucionNumero(int numeroEntrada, int numeroLimite){
        this.numeroEntrada = numeroEntrada;
        this.numeroLimite = numeroLimite;
        this.latencia = 100;
    }

    @Override
    public void run(){
        for (int i = numeroEntrada; i >= numeroLimite; i--){
            System.out.println("Numero Disminuyendo en: " + i);
            try {
                Thread.sleep(latencia);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
