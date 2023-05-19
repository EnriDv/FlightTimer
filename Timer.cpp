#include <iostream>
using namespace std;

double calcularTiempoVuelo(double distancia, double velocidad)
{
    if (velocidad <= 0)
    {
        cout << "Error: La velocidad debe ser mayor que cero." << endl;
        return 0.0;
    }

    return distancia / velocidad;
}

int main()
{
    double distancia, velocidad;

    cout << "Ingrese la distancia entre los puntos (en kilómetros): ";
    cin >> distancia;

    cout << "Ingrese la velocidad del avión (en kilómetros por hora): ";
    cin >> velocidad;

    double tiempoVuelo = calcularTiempoVuelo(distancia, velocidad);

    cout << "El tiempo de vuelo estimado es: " << tiempoVuelo << " horas." << endl;

    return 0;
}
