using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
     public class ToDoTask
     {
          //ID
          public Guid TaskId { get; set; }

          //Descripción de la actividad
          [Required(ErrorMessage = "Campo Task es Requerido")]
          [StringLength(20)]
          public string Description { get; set; }

          //Estado de la actividad
          public TaskState TaskState { get; set; }

          //Fecha de Creación
          public DateTime DateCreated { get; set; } = DateTime.Now;
     }

     //Metodo para enlistar estados de tareas o actividades
     public enum TaskState
     {
          Activo,
          Inactivo,
          Terminado
     }
}