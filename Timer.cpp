#include <iostream>
using namespace std;

double calcularTiempoVuelo(double distancia, double velocidad)
{
    if (velocidad <= 0)
    {
        cout << "Error: La velocidad debe ser mayor que cero." << endl;
        return 0.0;
    }

    return (distancia / velocidad)*60;
}

int main()
{
    double distancia, velocidad;

    cout << "Ingrese la distancia entre los puntos (en kilómetros): ";
    cin >> distancia;

    //Tomamos en cuenta la velocidad media del avion como 250 Km/h
    velocidad=250;

    double tiempoVuelo = calcularTiempoVuelo(distancia, velocidad);

    cout << "El tiempo de vuelo estimado es: " << tiempoVuelo << " minutos." << endl;

    return 0;
}
