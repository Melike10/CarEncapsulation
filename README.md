# CarEncapsulation

Bu proje, C# dilinde kapsülleme (encapsulation) kavramını kullanarak bir `Car` sınıfının nasıl oluşturulacağını göstermektedir. 
This project demonstrates how to create a `Car` class in C# using the concept of encapsulation.

## İçerik

- [Genel Bakış](#genel-bakış)
- [Kullanım](#kullanım)
- [Kod Açıklaması](#kod-açıklaması)


## Genel Bakış

Tur-`CarEncapsulation` projesi, bir araba nesnesinin özelliklerini (marka, model, renk ve kapı sayısı) kapsülleme kullanarak kontrol eder. Kapı sayısı yalnızca 2 veya 4 olabilir; aksi takdirde bir hata mesajı yazdırılır ve kapı sayısı -1 olarak ayarlanır.
Eng- The `CarEncapsulation` project uses encapsulation to manage the properties of a car object (make, model, color, and number of doors). The number of doors can only be 2 or 4; otherwise, an error message is printed, and the number of doors is set to -1.


## Kullanım
-Aşağıdaki kod parçacığı, Car sınıfının nasıl kullanılacağını göstermektedir:
-The following code snippet demonstrates how to use the Car class:

csharp
Copy code
using System;

namespace CarEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car araba = new Car("Toyota", "Corolla", "Kırmızı", 4);
            araba.Info();

            Car araba2 = new Car("Honda", "Civic", "Mavi", 3); // Bu hatalı bir giriş örneğidir.
            araba2.Info();
        }
    }
}

Yukarıdaki örnekte, araba2 nesnesinin kapı sayısı hatalı olarak 3 girildiği için kapı sayısı -1 olarak ayarlanır ve hata mesajı konsola yazdırılır.
In the example above, the car2 object has an invalid door count of 3, so the door count is set to -1, and an error message is printed to the console.

## Kod-Açıklaması
Car Sınıfı
Marka, Model, Renk: Arabanın markası, modeli ve rengi gibi genel özelliklerdir.
_kapi: Kapı sayısı için özel bir alan (field).
Kapi: Kapı sayısını kontrol eden ve yalnızca 2 veya 4 değerlerini kabul eden bir özellik (property).
Info(): Arabanın özelliklerini konsola yazdıran bir yöntem (method).
Kapsülleme (Encapsulation)
Kapı sayısı özelliği (_kapi) özel (private) olarak tanımlanmış ve yalnızca Kapi özelliği aracılığıyla erişilebilir hale getirilmiştir. Bu sayede kapı sayısının yalnızca 2 veya 4 değerlerini alması garanti altına alınmıştır.

Car Class
Marka, Model, Renk: General properties for the car's make, model, and color.
_kapi: Private field for the number of doors.
Kapi: Property that controls the number of doors, allowing only values of 2 or 4.
Info(): Method that prints the car's properties to the console.
Encapsulation
The door count property (_kapi) is defined as private and is accessible only through the Kapi property. This ensures that the door count can only be 2 or 4.

