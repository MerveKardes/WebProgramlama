﻿using E_Ticaret.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Interfaces
{
   public interface IUrunRepository: IGenericRepository<Urun>
    {
        List<Kategori> GetirKategoriler(int urunId);
    }
}
