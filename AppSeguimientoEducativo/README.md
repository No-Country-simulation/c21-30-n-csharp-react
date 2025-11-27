# Plataforma de Seguimiento Educativo

Sistema API RESTful desarrollado en **.NET 9** para la gestión integral de instituciones educativas. Permite administrar estudiantes, profesores, padres, cursos, calificaciones y retroalimentación académica.

## 🎯 Características Principales

- ✅ **Autenticación JWT** - Sistema seguro de autenticación basado en tokens
- 👥 **Gestión de Usuarios** - Administración de roles: Estudiantes, Profesores, Padres y Administradores
- 📚 **Gestión Académica** - Control completo de cursos, períodos académicos y asignaturas
- 📊 **Calificaciones** - Sistema de registro y actualización de notas
- 💬 **Retroalimentación** - Canal de comunicación entre profesores y estudiantes
- 🏗️ **Arquitectura Limpia** - Implementación de Repository Pattern y Unit of Work
- 🔒 **Manejo Global de Excepciones** - Middleware centralizado para gestión de errores

## 🛠️ Tecnologías Utilizadas

- **.NET 9.0** - Framework principal
- **ASP.NET Core Web API** - Para la construcción de servicios RESTful
- **Entity Framework Core** - ORM para acceso a datos
- **SQL Server** - Base de datos relacional
- **JWT Bearer Authentication** - Autenticación segura
- **Swagger/OpenAPI** - Documentación interactiva de la API
- **C# 12** - Última versión del lenguaje con Records y características modernas

## 📁 Estructura del Proyecto

```
PlataformaSeguimientoEducativo/
├── Controllers/          # Endpoints de la API
│   ├── AcademicPeriodController.cs
│   ├── CoursesController.cs
│   ├── FeedbacksController.cs
│   ├── GradesController.cs
│   ├── ParentsController.cs
│   ├── StudentsController.cs
│   ├── TeachersController.cs
│   └── UsersController.cs
│
├── Services/            # Lógica de negocio
│   ├── CourseService.cs
│   ├── FeedbackService.cs
│   ├── GradeService.cs
│   ├── ParentService.cs
│   ├── StudentService.cs
│   ├── TeacherService.cs
│   └── UserService.cs
│
├── Repositories/        # Acceso a datos
│   ├── Repository.cs
│   ├── UnitOfWork.cs
│   └── [Specific Repositories]
│
├── Models/              # Entidades del dominio
│   ├── User.cs
│   ├── Student.cs
│   ├── Teacher.cs
│   ├── Parent.cs
│   ├── Course.cs
│   ├── Grade.cs
│   ├── Feedback.cs
│   └── [Others]
│
├── DTOs/                # Data Transfer Objects (Records)
│   ├── LoginDto.cs
│   ├── RegisterUserDto.cs
│   ├── StudentDashboardDto.cs
│   ├── GradeDto.cs
│   └── [Others]
│
├── Data/                # Configuración de base de datos
│   ├── PSEduDbContext.cs
│   └── DbInitializer.cs
│
├── Middleware/          # Middleware personalizado
│   └── GlobalExceptionHandler.cs
│
└── Program.cs           # Punto de entrada y configuración
```

## 🚀 Configuración e Instalación

### Prerrequisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server (LocalDB, Express o superior)
- Visual Studio 2022 / VS Code / Rider

### Pasos de Instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/tu-usuario/AppSeguimientoEducativo.git
   cd AppSeguimientoEducativo/PlataformaSeguimientoEducativo
   ```

2. **Configurar la cadena de conexión**
   
   Edita `appsettings.json` y actualiza la conexión a tu base de datos:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=PSEduDb;Trusted_Connection=true;TrustServerCertificate=true"
     }
   }
   ```

3. **Configurar JWT**
   
   Actualiza las configuraciones de JWT en `appsettings.json`:
   ```json
   {
     "Jwt": {
       "Key": "tu-clave-secreta-muy-segura-de-al-menos-32-caracteres",
       "Issuer": "PlataformaSeguimientoEducativo"
     }
   }
   ```

4. **Restaurar paquetes NuGet**
   ```bash
   dotnet restore
   ```

5. **Aplicar migraciones**
   ```bash
   dotnet ef database update
   ```
   
   Si no tienes las herramientas de EF Core:
   ```bash
   dotnet tool install --global dotnet-ef
   ```

6. **Ejecutar el proyecto**
   ```bash
   dotnet run
   ```

7. **Acceder a Swagger UI**
   
   Abre tu navegador en: `https://localhost:7XXX/swagger` (el puerto se mostrará en la consola)

## 📋 Endpoints Principales

### Autenticación

- `POST /api/Users/login` - Iniciar sesión
- `POST /api/Users/register` - Registrar nuevo usuario
- `POST /api/Users/change-password` - Cambiar contraseña

### Estudiantes

- `GET /api/Students` - Obtener todos los estudiantes
- `GET /api/Students/{id}` - Obtener estudiante por ID
- `POST /api/Students` - Registrar nuevo estudiante
- `GET /api/Students/dashboard/{userId}` - Dashboard del estudiante
- `DELETE /api/Students/{id}` - Eliminar estudiante

### Profesores

- `GET /api/Teachers` - Obtener todos los profesores
- `GET /api/Teachers/{id}` - Obtener profesor por ID
- `POST /api/Teachers` - Registrar nuevo profesor
- `DELETE /api/Teachers/{id}` - Eliminar profesor

### Cursos

- `GET /api/Courses` - Obtener todos los cursos
- `GET /api/Courses/{id}` - Obtener curso por ID
- `POST /api/Courses` - Crear nuevo curso
- `DELETE /api/Courses/{id}` - Eliminar curso

### Calificaciones

- `GET /api/Grades/student/{studentId}` - Obtener calificaciones de un estudiante
- `POST /api/Grades/student/{studentId}` - Agregar calificación
- `PUT /api/Grades/student/{studentId}` - Actualizar calificación

### Retroalimentación

- `GET /api/Feedbacks/student/{studentId}/course/{courseId}` - Obtener feedback
- `POST /api/Feedbacks` - Crear feedback
- `PUT /api/Feedbacks` - Actualizar feedback

### Períodos Académicos

- `GET /api/AcademicPeriod/academicperiod` - Obtener todos los períodos académicos

### Padres

- `GET /api/Parents/dashboard/{userId}` - Dashboard del padre

## 🔑 Autenticación

La API utiliza **JWT (JSON Web Tokens)** para la autenticación. Sigue estos pasos:

1. **Hacer login:**
   ```json
   POST /api/Users/login
   {
     "email": "usuario@example.com",
     "password": "contraseña"
   }
   ```

2. **Recibir token:**
   ```json
   {
     "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...",
     "user": {...}
   }
   ```

3. **Usar el token:**
   
   Incluye el token en el header `Authorization` de tus peticiones:
   ```
   Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
   ```

## 👥 Roles de Usuario

El sistema maneja 4 roles principales:

- **Student** - Estudiantes que pueden ver sus cursos y calificaciones
- **Teacher** - Profesores que gestionan cursos y asignan calificaciones
- **Parent** - Padres que monitorean el progreso de sus hijos
- **Admin** - Administradores con acceso completo al sistema

## 🏗️ Arquitectura

### Patrón Repository y Unit of Work

El proyecto implementa el patrón Repository para abstraer el acceso a datos y el patrón Unit of Work para gestionar transacciones:

```csharp
public interface IUnitOfWork
{
    IStudentRepository Students { get; }
    ITeacherRepository Teachers { get; }
    ICourseRepository Courses { get; }
    IGradeRepository Grades { get; }
    // ... otros repositorios
    Task<int> CompleteAsync();
}
```

### DTOs como Records

Todos los DTOs están implementados como **C# Records** para aprovechar:
- Inmutabilidad por defecto (`init` properties)
- Sintaxis concisa
- Comparación por valor
- Deconstrucción

```csharp
public record LoginDto
{
    [Required]
    [EmailAddress]
    public string Email { get; init; }

    [Required]
    public string Password { get; init; }
}
```

### Manejo Global de Excepciones

El middleware `GlobalExceptionHandler` captura todas las excepciones no controladas y devuelve respuestas consistentes:

```csharp
{
  "status": 500,
  "title": "Server Error",
  "detail": "An internal server error has occurred."
}
```

## 🗄️ Modelo de Datos

### Entidades Principales

- **User** - Usuario base del sistema
- **Student** - Estudiante asociado a un usuario
- **Teacher** - Profesor asociado a un usuario
- **Parent** - Padre asociado a un usuario
- **Course** - Curso/Materia
- **Grade** - Calificación
- **Feedback** - Retroalimentación
- **AcademicPeriod** - Período académico (trimestre, semestre, etc.)
- **Role** - Rol del sistema
- **ParentStudent** - Relación entre padres e hijos
- **Communication** - Mensajes entre usuarios
- **Notification** - Notificaciones del sistema

## 📝 Mejoras Recientes

### Modernización a .NET 9

El proyecto ha sido actualizado de .NET 8 a .NET 9, aprovechando las últimas características y mejoras de rendimiento.

### Refactorización de DTOs

Todos los DTOs han sido refactorizados de `class` a `record`, mejorando:
- Inmutabilidad de datos
- Código más conciso y legible
- Mejor rendimiento en comparaciones

### Implementación de Middleware de Excepciones

Se agregó un middleware global para manejo consistente de errores en toda la aplicación.

### Organización de Archivos

Restructuración completa para una arquitectura más limpia y mantenible.

## 🧪 Testing

Para ejecutar las pruebas (cuando estén disponibles):
```bash
dotnet test
```

## 📦 Dependencias Clave

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="9.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="9.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="9.0.0" />
<PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="9.0.0" />
<PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="9.0.0" />
<PackageReference Include="Swashbuckle.AspNetCore" Version="7.2.0" />
```

## 🤝 Contribuciones

Las contribuciones son bienvenidas. Por favor:

1. Haz fork del proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📄 Licencia

Este proyecto está bajo la licencia MIT. Ver el archivo `LICENSE` para más detalles.

## 👨‍💻 Autores

- **Equipo de Desarrollo c21-30-n-csharp-react**
- Proyecto No Country

## 📞 Soporte

Para reportar problemas o sugerencias, por favor abre un issue en el repositorio de GitHub.

---

**Nota:** Este proyecto es parte de una simulación de desarrollo de No Country y tiene fines educativos y de demostración de habilidades.
