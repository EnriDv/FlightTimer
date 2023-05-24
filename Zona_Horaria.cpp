#include <iostream>
using namespace std;

void convertirHoras(int horas, int zonaHoraria) {
    // Ajuste de horas según la zona horaria
    horas += zonaHoraria;

    // Asegurarse de que las horas estén en el rango de 0 a 24
    if (horas < 0) {
        horas += 24;
    } else if (horas >= 24) {
        horas -= 24;
    }

    // Mostrar el resultado
    cout << "Hora convertida: " << horas << ":00" << endl;
}

int main() {
    int horas, zonaHoraria;

    // Obtener la hora del modulo correspondiente
    cout << "Ingrese la hora (en formato de 24 horas): ";
    cin >> horas;
    // Solicitar zona horaria al usuario
    cout << "Ingrese la zona horaria (en horas, ej. -5 para GMT-5): ";
    cin >> zonaHoraria;

    // Llamar a la función para convertir las horas
    convertirHoras(horas, zonaHoraria);

    return 0;
}
