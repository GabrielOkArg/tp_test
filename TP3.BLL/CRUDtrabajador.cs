using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3.BE;
using TP3.BLL.interfaces;
using TP3.DAL;

namespace TP3.BLL
{
    public class CRUDtrabajador : Icrud<Trabajador>
    {

        private TrabajadorRepository _repository;

        public CRUDtrabajador()
        {
            _repository = new TrabajadorRepository();
        }
        public void Delete(Trabajador entity)
        {
            throw new NotImplementedException();
        }

        public Trabajador FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Trabajador> GetAll()
        {
            List<Trabajador> trabajadores = _repository.ObtenerTrabajadores();
            foreach (var item in trabajadores)
            {
                item.Sueldo = CalcularSueldo.Calcular(item);
            }
            return trabajadores;
        }

        public void Insert(Trabajador entity)
        {
           _repository.AgregarTrabajador(entity);
        }

        public void Update(Trabajador entity)
        {
            throw new NotImplementedException();
        }
    }

    }

