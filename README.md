# GridControlsInWpf_Blog

Ukázková WPF aplikace k blogovému příspěvku o mřížkových ovládacích prvcích.

## Obsah

- `GridControlsInWpf_Blog` - hlavní okno a tři varianty zobrazení dat:
  - `GridView1` - `ListView` s dynamicky vytvořeným `GridView`,
  - `GridView2` - `ListView` s `GridView` definovaným v XAML,
  - `DataGrid1` - `DataGrid`.
- `DynamicPanelControlsInWpf` - druhá ukázka, dynamické zobrazení `GridUC` a `StackPanelUC` v okně.
- `Source.cs` - ukázková data (seznam autorů a knih).

## Technologie

- .NET 9 (net9.0-windows), WPF.
- Závislosti na sdílených balíčcích `SunamoShared`, `desktop` a `Xlf` z vlastního repa `PlatformIndependentNuGetPackages`.

## Sestavení

- Otevři `GridControlsInWpf_Blog.sln` ve Visual Studiu a spusť projekt `GridControlsInWpf_Blog`.
- Relativní `ProjectReference` na `PlatformIndependentNuGetPackages` musí na disku existovat.
