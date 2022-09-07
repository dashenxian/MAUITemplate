using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITemplate.Models
{
    public abstract class Entity<TKey>: IEntity<TKey>
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public TKey Id { get; set; }
    }
}
