﻿using DAL.Entity_Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity_BLLs
{
    public class ProductosEnCombo_BLL
    {
        ProductosEnCombo_Mapper ProductosEnCombo_Mapper = new ProductosEnCombo_Mapper();

        public DataTable ObteneRegistrosPorIDCombo(int idCombo)
        {
            return ProductosEnCombo_Mapper.ObtenerRegistrosPorIDCombo(idCombo);
        }
    }
}