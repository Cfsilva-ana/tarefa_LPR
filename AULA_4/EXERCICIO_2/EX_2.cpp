#include <iostream>

using namespace std;

int main() {

    int n1, n2;
    int maior ;
    int menor ;

    cout << "Digite dois numeros inteiros: ";

    if (!(cin >> n1 >> n2)) 
    { 
        cout << "Entrada invalida! Apenas numeros inteiros sao permitidos." << endl;
        return 0; 
    }

    if (n1 > n2) 
    {
        maior = n1;
        menor = n2;
    } 
    else
    {
        maior = n2;
        menor = n1;
    }
    if (maior % menor == 0)
    {
        cout << maior << " e multiplo de " << menor << "." << endl;
    } else 
    
    {
        cout << maior << " nao e multiplo de " << menor << "." << endl;
    }




}