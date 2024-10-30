using BlazorApp.Components;

namespace BlazorApp.Servicios
{
    public class ProductService
    {
        public Producto[] productos = new Producto[]
     {
        new Producto { Id= 1 , Nombre = "Smartphone",Precio=699,Descripcion="Dispositivo móvil con pantalla táctil, cámara de alta resolución y acceso a aplicaciones"},
        new Producto { Id= 2 , Nombre = "Laptop",Precio=999,Descripcion="Ordenador portátil ideal para trabajar, estudiar o jugar, con una batería de larga duración."},
        new Producto { Id= 3 , Nombre = "Tablet",Precio=499,Descripcion="Dispositivo portátil con pantalla táctil, perfecto para leer, navegar por Internet y ver películas."},
        new Producto { Id= 4 , Nombre = "Auriculares inalámbricos",Precio=149,Descripcion="Auriculares sin cables que ofrecen comodidad y calidad de sonido, ideales para hacer ejercicio o viajar."},
        new Producto { Id= 5 , Nombre = "Reloj inteligente",Precio=299,Descripcion="Dispositivo wearable que permite recibir notificaciones y monitorear la actividad física desde la muñeca."},




     };
        
    }
}
