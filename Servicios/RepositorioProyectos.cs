using Veterinaria.Models;

namespace Veterinaria.Servicios
{
    public class RepositoriosProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
                {
                    Titulo="Asesoria de imagen",
                    Descripcion="Peluquería Canina y Felina, el mejor estilo y el mejor look para tu mascota.",
                    Link="https://hvdes.com/asesoria-de-imagen-peluqueria/",
                    ImagenUrl="/imagenes/asesoria.jpg"
                },
                new Proyecto
                {
                    Titulo="Especialidades",
                    Descripcion="Contamos con diferentes especialidades para la salud de los más consentidos del hogar.",
                    Link="https://hvdes.com/especialidades/",
                    ImagenUrl="/imagenes/especialidades.jpg"
                },
                new Proyecto
                {
                    Titulo="Farmacia 24/7",
                    Descripcion="Farmacia equipada para dar soporte a tus tratamientos las 24 horas.",
                    Link="https://hvdes.com/farmacia/",
                    ImagenUrl="/imagenes/farmacia.jpg"
                },
                new Proyecto
                {
                    Titulo="Servicios",
                    Descripcion="Nuestros Servicios.",
                    Link="https://www.dogtorscat.com/servicios/",
                    ImagenUrl="/imagenes/servicios.jpg"
                },
                new Proyecto
                {
                    Titulo="Hospitalización",
                    Descripcion="Hospitalización Veterinaria.",
                    Link="https://www.dogtorscat.com/servicios/?slug=hospitalizacion&i=servicios",
                    ImagenUrl="/imagenes/hospitalizacion.jpg"
                },
                new Proyecto
                {
                    Titulo="Adopción",
                    Descripcion="Adopción de mascotas.",
                    Link="https://medipet.com.ec/adopciones/",
                    ImagenUrl="/imagenes/adopcion.jpg"
                },
                new Proyecto
                {
                    Titulo="Hotel",
                    Descripcion="Hospedaje de Perros.",
                    Link="https://medipet.com.ec/hotel-perros/",
                    ImagenUrl="/imagenes/hotel.jpg"
                },
                new Proyecto
                {
                    Titulo="Medicina",
                    Descripcion="Medicina Felina.",
                    Link="https://medipet.com.ec/medicina-felina/",
                    ImagenUrl="/imagenes/medicinafelina.jpg"
                },
                new Proyecto
                {
                    Titulo="Fisioterapia & Rehabilitación",
                    Descripcion="Contamos con médicos especializados en técnicas de Fisioterapia y Rehabilitación Veterinarias.",
                    Link="https://medipet.com.ec/servicio-fisioterapia-y-rehabilitacion/",
                    ImagenUrl="/imagenes/fisioterapiayrehabilitación.jpg"
                },
                new Proyecto
                {
                    Titulo="Rayos X & Radiografía",
                    Descripcion="El Hospital Veterinario Medipet cuenta con un equipo de Radiología Digital.",
                    Link="https://medipet.com.ec/rayos-x-y-radiografia/",
                    ImagenUrl="/imagenes/rayosxyradiografía.jpg"
                },

            };
        }
    }
}
