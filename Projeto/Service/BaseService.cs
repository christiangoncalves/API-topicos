using Projeto.DAO;
using Projeto.VO;
using Projeto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Projeto.Service
{
    public abstract class BaseService<Entity, VO, TContext, AutoMapProfile, DAO>
    where Entity : BaseEntity, new()
    where TContext : DbContext, new()
    where AutoMapProfile : Profile, new()
    where DAO: BaseDAO<Entity, VO, TContext, AutoMapProfile>, new()
    where VO: BaseVO, new()
    {
        DAO dao = new DAO();

        public VO save(VO vo)
        {
            try
            {
                if (vo.id > 0)
                {
                    dao.Save(vo);
                    return vo;
                }
                return null;
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public bool Update(VO vo)
        {
            try
            {
                return dao.Update(vo);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public List<VO> GetAll(int pageNumber, int pageSize, VO filter = null)
        {
            try
            {
                return dao.Select(pageNumber, pageSize, filter);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public VO GetOne(int id = 0)
        {
            try
            {
                return dao.SelectOne(id);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return dao.Delete(id);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }
    }
}