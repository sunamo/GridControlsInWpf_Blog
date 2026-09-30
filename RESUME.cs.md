---
schema_version: 5
type: learning
file_count: 37
delete_recommendation_percent: 40
generated_date: 2026-09-30
generated_time: 16:22:54
github_origin: no
github_source_url: 
first_commit_date: 2019-11-06
last_commit_date: 2025-03-05
commit_count: 46
---

## Description

Malá WPF ukázka (dva projekty) ke starému blogovému příspěvku o mřížkových ovládacích prvcích. Porovnává tři způsoby zobrazení tabulky: dynamicky vytvořený GridView, GridView v XAML a DataGrid. Druhý projekt ukazuje dynamické střídání panelů v okně. Cílí na net9.0-windows a spoléhá na sdílené balíčky Sunamo.

## Původ zdrojáků

Staženo z GitHubu: **ne** — ukázkový kód a vlastní autor, žádná vazba na cizí GitHub repo.

- Ověřeno: remote je vlastní sunamo/GridControlsInWpf_Blog, historie od 2019 s jediným autorem (Radek Jančík), gh search "GridControlsInWpf_Blog DynamicPanelControlsInWpf" a "GridControlsInWpf" našly jen vlastní repo, ukázková data ve Source.cs jsou jen textové řetězce.

## Doporučení ke smazání

Doporučení ke smazání: **40 %** — malý ukázkový projekt z roku 2019 bez produkčního užití.

- Jde o tutoriálovou ukázku se dvěma malými WPF projekty a ukázkovými daty.
- Poslední reálný commit v kódu je z roku 2019, později jen údržba sln a balíčků.
- Build závisí na relativní cestě do PlatformIndependentNuGetPackages.

## Historie commitů

- První commit: 2019-11-06
- Poslední commit: 2025-03-05
- Celkem commitů: 46

- Počítá se bez commitů, které jen generovaly RESUME.cs.md nebo README.md.
