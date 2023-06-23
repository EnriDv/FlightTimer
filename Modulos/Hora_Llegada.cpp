#include <iostream>
using namespace std;

// Función para calcular la hora de llegada
void calcularHoraLlegada(int horaSalida, int minutosSalida, int duracionVuelo) {
    int totalMinutos = (horaSalida * 60) + minutosSalida; // Convertir a minutos
    totalMinutos += duracionVuelo; // Sumar la duración del vuelo
    int horaLlegada = totalMinutos / 60; // Obtener la hora de llegada
    int minutosLlegada = totalMinutos % 60; // Obtener los minutos de llegada

    // Imprimir la hora de llegada
    cout << "Hora de llegada: " << horaLlegada << ":" << minutosLlegada << endl;
}

int main() {
    int horaSalida, minutosSalida, duracionVuelo;

    // Obtener el tiempo de salida del usuario
    cout << "Ingrese la hora de salida (formato 24 horas): ";
    cin >> horaSalida;
    cout << "Ingrese los minutos de salida: ";
    cin >> minutosSalida;

    // Obtener la duración del vuelo del modulo de vuelo
    cout << "Ingrese la duracion del vuelo en minutos: ";
    cin >> duracionVuelo;

    // Calcular y mostrar la hora de llegada
    calcularHoraLlegada(horaSalida, minutosSalida, duracionVuelo);

    return 0;
}
