# Repository Guidelines

## Project Structure & Module Organization
- Solution entry: `OnlineShopBlazorSln.slnx`; main app in `OnlineShopBlazor/`.
- UI: Razor components under `OnlineShopBlazor/Components/` (`Admin/`, `Layout/`, `Pages/`) with routing in `App.razor` and `Routes.razor`.
- Assets: static files in `OnlineShopBlazor/wwwroot/`; configuration in `appsettings.json` and overrides in `appsettings.Development.json`.
- Build artifacts: `bin/` and `obj/` are local outputs; keep them out of commits.

## Build, Test, and Development Commands
- Restore dependencies: `dotnet restore OnlineShopBlazorSln.slnx`.
- Build solution: `dotnet build OnlineShopBlazorSln.slnx` (compiles C# and validates Razor).
- Run locally: `dotnet run --project OnlineShopBlazor` (starts HTTPS server-side Blazor).
- Live reload: `dotnet watch --project OnlineShopBlazor` for iterative UI changes.
- Tests: none present; once added, run with `dotnet test`.

## MCP Server Configuration
- Configurazione centralizzata in `.vscode/mcp.json`; mantenere aggiornata la lista dei server usati nel progetto.
- Server attuali: `filesystem`, `mssql-local`, `mongo`, `dotnet-blazor-helper` (collegato al tool `radzen.mcp`).
- Prima di avviare un server installare il relativo tool (es. `dotnet tool install -g Radzen.Mcp`) e verificare che il comando sia nel `PATH`.
- Rimuovere o aggiornare le voci per i server non installati, altrimenti resteranno in stato `Stopped` in VS Code.

## Coding Style & Naming Conventions
- C# with 4-space indentation; keep files ASCII.
- Naming: PascalCase for classes/components/files (e.g., `Home.razor`), camelCase for locals/parameters, UPPER_SNAKE_CASE for constants.
- Razor: keep components near their scoped CSS (e.g., `AdminLayout.razor.css`); use code-behind only when logic grows.
- Formatting: run `dotnet format` before commits to align whitespace and usings.

## Testing Guidelines
- Add tests with xUnit or MSTest under `Tests/` and include them in the solution.
- Use behavior-driven names (`Component_Method_ShouldExpectation`) and isolate fixtures.
- Target coverage for routing, component rendering, and service interactions; include screenshots for UI regressions when useful.

## Commit & Pull Request Guidelines
- Use short, imperative English commit subjects (e.g., `Add admin layout navigation`, `Fix Weather table spacing`) and keep each commit focused.
- PRs should include: purpose summary, linked issue/task ID, test notes (`dotnet build`, `dotnet run` smoke), and UI screenshots or GIFs for layout changes.

## Security & Configuration Tips
- Never commit secrets; store them in user secrets or environment variables, not in `appsettings*.json`.
- HTTPS is enabled by default; if local requests fail, refresh development certificates.
- When adding third-party packages or scripts, note licenses and pin versions in the PR description.

## Indicazioni di Collaborazione (Richiesta Utente)
- Lingua della chat: tutti i messaggi di progetto devono essere in italiano.

### Procedura di modifica
1) Analizza il progetto e identifica la modifica da eseguire.  
2) Crea una checklist concettuale (1-7 punti numerati) e presentala prima di procedere, usando indicatori grafici con casella verde `🟩` per gli step aperti e casella gialla barrata `🟨 ~~...~~` per quelli completati.  
3) Richiedi conferma per ogni step prima di passare al successivo.  
4) Dopo ogni modifica o uso di tool, valida l'esito in 1-2 frasi e correggi prima di continuare se serve.  
5) Testa e verifica attentamente il codice inserito o modificato.  
6) Dopo ogni modifica, riformatta i file toccati per mantenere coerenza stilistica.  
   In caso di dubbi, chiarisci prima di redigere la checklist, suddividi gli step complessi ottenendo conferma per ogni sotto-punto e proponi eventuali refactoring solo alla fine.

### Implementation Plan
- **Lingua**: Il contenuto dell'Implementation Plan deve essere SEMPRE tradotto interamente in ITALIANO.
