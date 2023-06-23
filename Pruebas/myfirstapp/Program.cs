namespace TestDemo;

public static class Timer
{
    
        public static double calcularTiempoVuelo(double distancia, double velocidad)
    {
    if (velocidad <= 0)
    {
        return 0;
    }

    return (distancia / velocidad)*60;
    }


        public static string calcularHoraLlegada(int horaSalida, int minutosSalida, int duracionVuelo) 
    {
    int totalMinutos = (horaSalida * 60) + minutosSalida; // Convertir a minutos
    totalMinutos += duracionVuelo; // Sumar la duración del vuelo
    int horaLlegada = totalMinutos / 60; // Obtener la hora de llegada
    int minutosLlegada = totalMinutos % 60; // Obtener los minutos de llegada
    string horas=horaLlegada.ToString()+":"+minutosLlegada.ToString();
    // Imprimir la hora de llegada
    return horas;
    //cout << "Hora de llegada: " << horaLlegada << ":" << minutosLlegada << endl;
    }

        public static int convertirHoras(int horas, int zonaHoraria)
    {
    // Ajuste de horas según la zona horaria
    horas += zonaHoraria;

    // Asegurarse de que las horas estén en el rango de 0 a 24
    if (horas < 0) {
        horas += 24;
    } else if (horas >= 24) {
        horas -= 24;
    }

    // Mostrar el resultado
    return horas;
    //cout << "Hora convertida: " << horas << ":00" << endl;

    }
    }