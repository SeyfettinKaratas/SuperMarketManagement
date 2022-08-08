using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.CategoryUseCase
{
    public class DeleteCategoryUsecase : IDeleteCategoryUsecase
    {
        private readonly ICategoryRepository categoryRepository;

        public DeleteCategoryUsecase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public void Delete(int categoryId)
        {
            categoryRepository.DeleteCategory(categoryId);
        }

    }
}
