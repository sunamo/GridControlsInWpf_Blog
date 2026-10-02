---
schema_version: 7
type: learning
file_count: 37
avg_lines_per_file: 35
move_to_legacy_percent: 40
generated_date: 2026-10-01
generated_time: 16:41:09
github_source_url: 
last_build_ok: no
last_build_date: 2026-10-02
last_tests_run_date: n/a
covered_lines: 0
total_lines: 894
---

## Description

Malá WPF ukázka (dva projekty) ke starému blogovému příspěvku o mřížkových ovládacích prvcích. Porovnává tři způsoby zobrazení tabulky: dynamicky vytvořený GridView, GridView v XAML a DataGrid. Druhý projekt ukazuje dynamické střídání panelů v okně. Cílí na net9.0-windows a spoléhá na sdílené balíčky Sunamo.

## Původ zdrojáků

Staženo z GitHubu: **ne** — ukázkový kód a vlastní autor, žádná vazba na cizí GitHub repo.

- Ověřeno: remote je vlastní sunamo/GridControlsInWpf_Blog, historie od 2019 s jediným autorem (Radek Jančík), gh search "GridControlsInWpf_Blog DynamicPanelControlsInWpf" a "GridControlsInWpf" našly jen vlastní repo, ukázková data ve Source.cs jsou jen textové řetězce.

## Doporučení přesunu do legacy

Doporučení přesunu do sunamocz-legacy.visualstudio.com: **40 %** — malý ukázkový projekt z roku 2019 bez produkčního užití.

- Jde o tutoriálovou ukázku se dvěma malými WPF projekty a ukázkovými daty.
- Poslední reálný commit v kódu je z roku 2019, později jen údržba sln a balíčků.
- Build závisí na relativní cestě do PlatformIndependentNuGetPackages.

## Vazby na moje repa

- Submoduly: žádné
- ProjectReference / PackageReference: žádné
