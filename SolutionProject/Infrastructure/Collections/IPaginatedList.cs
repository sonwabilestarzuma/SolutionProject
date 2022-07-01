using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionProject.Infrastructure.Collections
{
    public interface IPaginatedList
    {
        int PageIndex { get; }

        int TotalPages { get; }

        bool HasPreviousPage { get; }

        bool HasNextPage { get; }

        int SurroundingPagesCount { get; }
    }
}