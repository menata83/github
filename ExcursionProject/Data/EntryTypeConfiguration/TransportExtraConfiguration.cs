using country;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntryTypeConfiguration
{
    public class TransportExtraConfiguration : IEntityTypeConfiguration<TransportExtra>
    {
    public void Configure(EntityTypeBuilder<TransportExtra> builder)
     {
            builder.HasKey(tcm => new { tcm.ExcursionId, tcm.ExtraId });

            builder.HasOne(tcm => tcm.Excursion)
                .WithMany(testc => testc.TransportExtra)
                .HasForeignKey(tcm.ExcursionId);

            builder.HasOne(tcm => tcm.Extra)
                .WithMany(NetTcpStyleUriParser => NetTcpStyleUriParser.TransportExtra)
                .HasForeignKey(tcm.ExtraId);
     }
}
