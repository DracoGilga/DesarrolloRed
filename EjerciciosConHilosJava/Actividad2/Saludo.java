package Actividad2;

public class Saludo implements Runnable{
    private String saludo;

    public Saludo(String saludo){
        this.saludo = saludo;
    }

    @Override
    public void run(){
        for (int i = 0; i < 100; i++){
            System.out.print(saludo);
            try {
                Thread.sleep(200);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }
}
