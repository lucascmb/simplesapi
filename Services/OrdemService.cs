using DesafioBahia.Domain.Models;
using DesafioBahia.Domain.Repositories;
using DesafioBahia.Domain.Services;
using DesafioBahia.Resources;
using DesafioBahia.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBahia.Services
{
    public class OrdemService : IOrdemService
    {
        private readonly IOrdemRepository _ordemRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrdemService(IOrdemRepository ordemRepository, IUnitOfWork unityOfWork)
        {
            _ordemRepository = ordemRepository;
            _unitOfWork = unityOfWork;
        }

        public async Task<IEnumerable<Ordem>> ListAsync()
        {
            return await _ordemRepository.ListAsync();
        }

        public async Task<SaveOrdemResponse> SaveAsync(Ordem ordem)
        {
            try
            {
                await _ordemRepository.AddAsync(ordem);
                await _unitOfWork.CompleteAsync();

                return new SaveOrdemResponse(ordem);
            }
            catch(Exception ex)
            {
                return new SaveOrdemResponse($"Error : {ex.Message}");
            }
        }
    }
}
