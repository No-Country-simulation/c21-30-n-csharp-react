function Estudiante() {
    const calificaciones = [
        {
            asignatura: "Matemáticas",
            calificacion: 85,
            promedio: 88,
            docente: "Prof. García"
        },
        {
            asignatura: "Historia",
            calificacion: 90,
            promedio: 92,
            docente: "Prof. López"
        },
        {
            asignatura: "Ciencias",
            calificacion: 78,
            promedio: 80,
            docente: "Prof. Martínez"
        },
        {
            asignatura: "Literatura",
            calificacion: 92,
            promedio: 89,
            docente: "Prof. Fernández"
        }
    ];

    return (
        <div id="student" className="max-w-[1281px] mx-auto">
            <div className="flex items-center justify-between">
                <h2 className="text-[32px] font-extrabold">Historial Académico</h2>
                <div className="space-x-[23px]">
                    <span className="text-[#595353] font-extrabold">Periodo Seleccionado</span>
                    <select name="periodo" id="periodo">
                        <option value="2024-3">2024-3</option>
                    </select>
                </div>
            </div>
            <table className="w-full mt-[17px] text-center">
                <thead>
                    <tr>
                        <th>Asignatura</th>
                        <th>Calificación</th>
                        <th>Promedio por asignatura</th>
                        <th>Docente</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        calificaciones.map(({ asignatura, calificacion, docente, promedio }, index) =>
                            <tr key={index}>
                                <td className="py-[25px] px-[10px]">{asignatura}</td>
                                <td className="py-[25px] px-[10px]">{calificacion}</td>
                                <td className="py-[25px] px-[10px]">{promedio}</td>
                                <td className="py-[25px] px-[10px]">{docente}</td>
                            </tr>
                        )
                    }
                </tbody>
            </table>
            <div className="mx-auto w-max mt-[17px] mb-[85px]">
                <span className="text-[#595353] font-extrabold">Promedio del Periodo</span> 7.8
            </div>
            <div className="space-y-[18px]">
                <h2 className="font-extrabold text-[32px] text-center">Comentarios de los docentes</h2>
                <p className="text-sm text-center max-w-[690px] m-auto">En esta sección encontrará los comentarios y la retroalimentación proporcionada por los docentes.
                    Aquí podrá revisar observaciones detalladas sobre el desempeño, áreas de mejora y recomendaciones.</p>
            </div>
            <div className="mx-auto w-max my-[50px]">
                Período Seleccionado
                <select name="periodo" id="periodo">
                    <option value="2024-3">2024-3</option>
                </select>
            </div>
            <div className="mx-auto">
                <div className="space-y-[13px] p-[30px] w-[546px] rounded-[22px] mx-auto">
                    <div className="flex gap-[15px] items-center">
                        <div className="size-[68px] rounded-full bg-gray-300"></div>
                        <div>
                            <p className="font-semibold">Nombre completo del docente</p>
                            <p className="text-[#686666]">
                                Asignatura <br />
                                00/00/0000
                            </p>
                        </div>
                    </div>
                    <p>
                        Este es un ejemplo de comentario donde el docente dejará observaciones detalladas sobre el desempeño, áreas de mejora y recomendaciones del docente.
                    </p>
                </div>
            </div>
        </div>
    )
}

export default Estudiante;
