using System;

namespace LINQ_Scratchpad
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Dog fido = new Dog();

            Dog rex = new Dog
            {
                Name = "Rex",
                Skills = { "playing ball", "sniffing" }
            };

        }

        public void GetSkills() {
        }
        }

  
    }

            //public async Task<List<ExtensionValidationSetNode>> GetAllExtensionValidationSetNodes(IExtension source, CancellationToken cancellationToken)
            //{
            //    var validationSets = _dataProvider.GetAllValidationSets();
            //    var result = new List<ExtensionValidationSetNode>();
            //    var alternateValues = _alternateValueProvider.GetAlternateValuesForExtensionAsync(RequestContext.Internal, source.Id, cancellationToken).Result;
            //    foreach (var valset in validationSets)
            //    {
            //        var usedRecordCount = 0;
            //        var valSetEntries = await GetEntriesForValidationSetAsync(valset.Id, cancellationToken).ConfigureAwait(false);
            //        var numberOfValsetEntries = valSetEntries.Count;
            //        foreach (var entry in valSetEntries)
            //        {
            //            foreach (var altValue in alternateValues)
            //            {
            //                if (altValue.UsageTypeId == UsageType.ValidationSetEntry && altValue.RecordId == entry.Id)
            //                {
            //                    usedRecordCount++;
            //                }
            //            }
            //        }
            //        result.Add(new ExtensionValidationSetNode
            //        {
            //            ValidationSetName = valset.Name,
            //            ValidationSetId = valset.Id,
            //            TotalRecordCount = numberOfValsetEntries, // the number of Validation Set Entries that belong to that validation set
            //            UsedRecordCount = usedRecordCount  // the number of ValSetEntries that are tied to an alterate value
            //        });
            //    }
            //    return result;
            //}

            //public async Task<List<ExtensionValidationSetNode>> GetAllExtensionValidationSetNodesREFACTORED(IExtension source, CancellationToken cancellationToken)
            //{
            //    var validationSets = _dataProvider.GetAllValidationSets();
            //    var result = new List<ExtensionValidationSetNode>();
            //    var alternateValues = _alternateValueProvider.GetAlternateValuesForExtensionAsync(RequestContext.Internal, source.Id, cancellationToken).Result;

            //    var extensionValidationSetNode = new ExtensionValidationSetNode();
                
            //    foreach (var valset in validationSets)
            //    {
            //        var usedRecordCount = 0;
            //        var valSetEntries = await GetEntriesForValidationSetAsync(valset.Id, cancellationToken).ConfigureAwait(false);
            //        var numberOfValsetEntries = valSetEntries.Count;
            //        foreach (var entry in valSetEntries)
            //        {
            //            foreach (var altValue in alternateValues)
            //            {
            //                if (altValue.UsageTypeId == UsageType.ValidationSetEntry && altValue.RecordId == entry.Id)
            //                {
            //                    usedRecordCount++;
            //                }
            //            }
            //        }
            //        result.Add(new ExtensionValidationSetNode
            //        {
            //            ValidationSetName = valset.Name,
            //            ValidationSetId = valset.Id,
            //            TotalRecordCount = numberOfValsetEntries, // the number of Validation Set Entries that belong to that validation set
            //            UsedRecordCount = usedRecordCount  // the number of ValSetEntries that are tied to an alterate value
            //        });
            //    }
            //    return result;
            //}
        }
    }

