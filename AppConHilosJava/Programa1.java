public class Programa1 implements Runnable{
    @Override
    public void run(){
        System.out.println(Thread.currentThread().getName() + "Subproceso corriendo...");
    }
}