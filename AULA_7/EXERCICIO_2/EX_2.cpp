#include <iostream>
#include <vector>

using namespace std;
int main()
{
    vector<int> num(10); 
 
    cout << "Insira 10 numeros:" << endl;
    if (cin){

        for (int i = 0; i < num.size(); i++)
        {
            cout << "Numeros " << i + 1 << ": ";
            cin >> num[i];
        }

        
    }
    else
    {
        cout << "Reinicie o programa e insira numeros inteiros" << endl;
    }


}
