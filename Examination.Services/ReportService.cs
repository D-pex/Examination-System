using Examination.Core.Dtos;
using Examination.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Examination.Services;

public sealed class ReportService(AppDbContext dbContext)
{
    public List<ReportDto> GetTestReports()
    {
        var reports = dbContext.Tests
            .GroupJoin(
                dbContext.UserAttempts,
                t => t.Id,
                ua => ua.TestId,
                (t, attempts) => new ReportDto(
                    t.Name,
                    attempts.Count()
                )
            )
            .ToList();

        return reports;
    }
}