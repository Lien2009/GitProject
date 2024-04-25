using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public abstract class Repository<TDomain> : RepositoryBase, IRepository<TDomain>
        where TDomain : new()
      
    {
        protected virtual String TableName => string.Empty;
        private string GetAllColumnsName()
        {
            var listPropperties = typeof(TDomain).GetProperties().Select(x => x.Name).ToList();
            return string.Join(", ", listPropperties);
        }
        public virtual async Task<TDomain?> GetByIdAsync(String id)
        {
            var list = await this.GetAsync<TDomain>($"SELECT {this.GetAllColumnsName()} FROM {this.TableName} WHERE Id = @Id", "Id", id);
            return list;
        }

        //public virtual Task<Int32> InsertAsync(TEntity entity)
        //{
        //    var sql = this.BuildInsertSql(typeof(TEntity));
        //    return this.ExecuteAsync(sql, entity);
        //}

        //public virtual Task<Int32> AddAsync(TDomain domain, String tableName = null)
        //{
        //    var columns = this.GetColumns(typeof(TEntity));
        //    var sql = this.BuilInsertSql(tableName ?? this.TableName, columns);
        //    return this.ExecuteAsync(sql, ConvertToEntity(domain));
        //}
        
        //public virtual Task<Int32> DeleteByIdAsync(String id)
        //{
        //    return this.ExecuteAsync($"DELETE FROM {this.TableName} WHERE Id = @Id", this.BuildParameters("Id", id));
        //}
    }
}
