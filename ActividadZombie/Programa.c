#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>

int main(){
    int pid = fork();
    printf("Id del proceso %d\n", pid);
    
    if(pid>0)
        sleep(20);
    else if(pid==0)
    {
        printf("\n Proceso Zombie creado con exito");
        printf("\n Estara activo durante 20 segundos\n");
        exit(0);
    }
    else
        printf("\n Sentimos El proceso Hijo no pudo se Creado...");

    return 0;
}