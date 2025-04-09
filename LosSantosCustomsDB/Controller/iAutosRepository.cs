using LosSantosCustomsDB.Model;

namespace LosSantosCustomsDB.Controller
{
    internal interface iAutosRepository
    {
        List<Autos> Leer();
        bool Insertar(Autos auto);
        bool Actualizar(Autos auto);
        bool Eliminar(int idauto);
    }
}