import java.util.ArrayList;
import java.util.Stack;
import java.util.ArrayDeque;

public class Main{	
    public static void main(String[] args) {
        
        System.out.println("Passo 1: Insira os numeros 1, 2, 3, 4 e 5 em uma lista com 5 celulas:");
        ArrayList lista = new ArrayList(5); 
        for(int i=1; i<=5; i++){
            lista.add(i);
        }
        System.out.println(lista + "\n");
		
		System.out.println("Passo 2: Remova todos os dados da lista.\nDeve-se sempre remover os dados da celula inicial da lista."); 
		do{
		   System.out.print(lista + "\n");
		   lista.remove(0);
		}while(!lista.isEmpty());
	    System.out.println("\n" + "Insira-os em uma pilha com 5 celulas: ");
	    
	    Stack pilha = new Stack();
	    for(int i=1; i<=5; i++){
	        pilha.push(i);
	    }
	    System.out.println(pilha + "\n");
	    System.out.println("Passo 3: Remove os dados da pilha.");
	    pilha.clear();
	    System.out.println(pilha + "\n");
	    
	    System.out.println("Insira-os em uma fila com 10 celulas.");
	    ArrayDeque fila = new ArrayDeque(10);
	    for(int i=1; i<=5; i++){
	        fila.add(i);  
	    }
	    System.out.println(fila + "\n");
	    
	    System.out.println("Passo 4: Insira os numeros 6, 7, 8, 9 e 10 na lista.");
	    for(int i=6; i<=10; i++){
	        fila.add(i);
	    }
	    System.out.println(fila + "\n");
	    fila.clear();
	    
        System.out.println("Passo 5: Repita os passos 2 e 3:");
        System.out.println("Passo 2: Remova todos os dados da lista.\nDeve-se sempre remover os dados da célula inicial da lista.");
        for(int i=1; i<=5; i++){
            lista.add(i);
        }
	    do{
	        System.out.println(lista);
	        lista.remove(0);
	    }while(!lista.isEmpty());
	    
	    System.out.println("\n"+ "Passo 2: insira-os em uma pilha com 5 celulas.");
	    for(int i=1; i<=5; i++){
	        pilha.push(i);
	    }
	    System.out.println(pilha + "\n");
	    
	    System.out.println("Passo 3: Remove os dados da pilha.");
	    pilha.clear();
	    System.out.println(pilha + "\n");
	    
	    System.out.println("Passo 3: insira-os em uma fila com 10 celulas.");
	    for(int i=1; i<=5; i++){
	        fila.push(i);
	    }
	    System.out.println("Passo 6: Exiba todos os numeros que foram inseridos na fila.");
	    System.out.println(fila + "\n");
	}
}
