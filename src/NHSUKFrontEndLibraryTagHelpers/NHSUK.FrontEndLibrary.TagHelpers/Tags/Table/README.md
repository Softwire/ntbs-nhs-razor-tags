# Table

## Guidance

Find out more about the table component and when to use it in the [NHS digital service manual](https://beta.nhs.uk/service-manual/styles-components-patterns/table).

## Quick start examples

### Simple table

[Preview the table component](https://dotnetcorefelpoc.azurewebsites.net/components/tables)

#### HTML markup

```html
<table class="nhsuk-table">
  <caption class="nhsuk-table__caption">Skin symptoms and possible causes</caption>
  <thead class="nhsuk-table__head" role="rowgroup">
    <tr class="nhsuk-table__row" role="row">
      <th class="nhsuk-table__header" scope="col" role="columnheader">Skin symptoms</th>
      <th class="nhsuk-table__header" scope="col" role="columnheader">Possible cause</th>
    </tr>
  </thead>
  <tbody class="nhsuk-table__body">
    <tr class="nhsuk-table__row" role="row">
      <td class="nhsuk-table__cell">Blisters on lips or around the mouth</td>
      <td class="nhsuk-table__cell ">cold sores</td>
    </tr>
    <tr class="nhsuk-table__row" role="row">
      <td class="nhsuk-table__cell">Itchy, dry, cracked, sore</td>
      <td class="nhsuk-table__cell ">eczema</td>
    </tr>
    <tr class="nhsuk-table__row" role="row">
      <td class="nhsuk-table__cell">Itchy blisters</td>
      <td class="nhsuk-table__cell ">shingles, chickenpox</td>
    </tr>
  </tbody>
</table>
```

#### Taghelper markup

```
<nhs-table caption="Skin symptoms and possible causes">
  <nhs-table-head>
    <nhs-table-item>Skin symptoms</nhs-table-item>
    <nhs-table-item>Possible cause</nhs-table-item>
  </nhs-table-head>
  <nhs-table-body>
    <nhs-table-body-row>
      <nhs-table-item>Blisters on lips or around the mouth</nhs-table-item>
      <nhs-table-item>cold sores</nhs-table-item>
    </nhs-table-body-row>
    <nhs-table-body-row>
      <nhs-table-item>Itchy, dry, cracked, sore</nhs-table-item>
      <nhs-table-item>eczema</nhs-table-item>
    </nhs-table-body-row>
    <nhs-table-body-row>
      <nhs-table-item>Itchy blisters</nhs-table-item>
      <nhs-table-item>shingles, chickenpox</nhs-table-item>
    </nhs-table-body-row>
  </nhs-table-body>
</nhs-table>
```

---

### Responsive table

[Preview the table component](https://service-manual.nhs.uk/design-example/table-responsive)

#### HTML markup

```html
<table role="table" class="nhsuk-table-responsive">
  <caption class="nhsuk-table__caption">Ibuprofen tablet dosages for children</caption>
  <thead role="rowgroup" class="nhsuk-table__head">
    <tr role="row">
      <th role="columnheader" class="" scope="col">
        Age
      </th>
      <th role="columnheader" class="" scope="col">
        How much
      </th>
      <th role="columnheader" class="" scope="col">
        How often
      </th>
    </tr>
  </thead>
  <tbody class="nhsuk-table__body">
    <tr role="row" class="nhsuk-table__row">
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">Age</span>7 to 9 years
      </td>
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">How much</span>200mg
      </td>
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">How often</span>Max 3 times in 24 hours
      </td>
    </tr>
    <tr role="row" class="nhsuk-table__row">
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">Age</span>10 to 11 years
      </td>
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">How much</span>200mg to 300mg
      </td>
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">How often</span>Max 3 times in 24 hours
      </td>
    </tr>
    <tr role="row" class="nhsuk-table__row">
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">Age</span>12 to 17 years
      </td>
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">How much</span>200mg to 400mg
      </td>
      <td class="nhsuk-table__cell">
        <span class="nhsuk-table-responsive__heading">How often</span>Max 3 times in 24 hours
      </td>
    </tr>
  </tbody>
</table>
```

#### Taghelper markup

```
<nhs-table caption="Ibuprofen tablet dosages for children" responsive>
  <nhs-table-head>
    <nhs-table-item>Age</nhs-table-item>
    <nhs-table-item>How much</nhs-table-item>
    <nhs-table-item>How often</nhs-table-item>
  </nhs-table-head>
  <nhs-table-body>
    <nhs-table-body-row>
      <nhs-table-item heading-text="Age">7 to 9 years</nhs-table-item>
      <nhs-table-item heading-text="How much">200mg</nhs-table-item>
      <nhs-table-item heading-text="How often">Max 3 times in 24 hours</nhs-table-item>
    </nhs-table-body-row>
    <nhs-table-body-row>
      <nhs-table-item heading-text="Age">10 to 11 years</nhs-table-item>
      <nhs-table-item heading-text="How much">200mg to 300mg</nhs-table-item>
      <nhs-table-item heading-text="How often">Max 3 times in 24 hours</nhs-table-item>
    </nhs-table-body-row>
    <nhs-table-body-row>
      <nhs-table-item heading-text="Age">12 to 17 years</nhs-table-item>
      <nhs-table-item heading-text="How much">200mg to 400mg</nhs-table-item>
      <nhs-table-item heading-text="How often">Max 3 times in 24 hours</nhs-table-item>
    </nhs-table-body-row>
  </nhs-table-body>
</nhs-table>
```

---


### Table panel

[Preview the table panel component](https://dotnetcorefelpoc.azurewebsites.net/components/tables-panel)

#### HTML markup

```html
<div class="nhsuk-table__panel-with-heading-tab">
  <h3 class="nhsuk-table__heading-tab">Conditions similar to impetigo</h3>
  <table class="nhsuk-table">
    <caption class="nhsuk-table__caption">Other possible causes of your symptoms</caption>
    <thead class="nhsuk-table__head" role="rowgroup">
      <tr class="nhsuk-table__row" role="row">
        <th class="nhsuk-table__header" scope="col" role="columnheader">Symptoms</th>
        <th class="nhsuk-table__header" scope="col" role="columnheader">Possible cause</th>
      </tr>
    </thead>
    <tbody class="nhsuk-table__body">
      <tr class="nhsuk-table__row" role="row">
        <td class="nhsuk-table__cell">Blisters on lips or around the mouth</td>
        <td class="nhsuk-table__cell ">cold sores</td>
      </tr>
      <tr class="nhsuk-table__row" role="row">
        <td class="nhsuk-table__cell">Itchy, dry, cracked, sore</td>
        <td class="nhsuk-table__cell ">eczema</td>
      </tr>
      <tr class="nhsuk-table__row" role="row">
        <td class="nhsuk-table__cell">Itchy blisters</td>
        <td class="nhsuk-table__cell ">shingles, chickenpox</td>
      </tr>
    </tbody>
  </table>
</div>
```

#### Taghelper markup

```
<nhs-table is-with-panel="true" title-text="Conditions similar to impetigo" caption="Other possible causes of your symptoms">
  <nhs-table-head>
    <nhs-table-item>Symptoms</nhs-table-item>
    <nhs-table-item>Possible cause</nhs-table-item>
  </nhs-table-head>
  <nhs-table-body>
    <nhs-table-body-row>
      <nhs-table-item>Blisters on lips or around the mouth</nhs-table-item>
      <nhs-table-item>cold sores</nhs-table-item>
    </nhs-table-body-row>
    <nhs-table-body-row>
      <nhs-table-item>Itchy, dry, cracked, sore</nhs-table-item>
      <nhs-table-item>eczema</nhs-table-item>
    </nhs-table-body-row>
    <nhs-table-body-row>
      <nhs-table-item>Itchy blisters</nhs-table-item>
      <nhs-table-item>shingles, chickenpox</nhs-table-item>
    </nhs-table-body-row>
  </nhs-table-body>
</nhs-table>

```

---

### Taghelper attributes

The table taghelper markup takes the following attributes:

| Name                   | Type       | Required  | Description  |
| -----------------------|------------|-----------|--------------|
| **nhs-table-body-row**               | Taghelper      | Yes       | Taghelper representing a table body row. |
| **nhs-table-head**               | Taghelper      | No        | Optional table head. |
| **nhs-table-item**               | Taghelper      | Yes        | Taghelper representing a table row cell. |
| **nhs-table-body**               | Taghelper      | Yes        | Taghelper representing a table body. |
| **nhs-table-body-row**               | Taghelper      | Yes        | Taghelper representing a table body row. |
| **responsive**              | boolean    | No        | If set to true, the responsive table CSS class is used |
| **is-with-panel**              | boolean    | No        | If set to true, the table is rendered inside a panel with a label. |
| **title-text**            | string     | No        | Heading/label of the panel if the panel argument is set to true. |
| **caption**            | string     | No        | Optional caption for the table. |
| **nhs-table-item.cell-is-header**  | boolean    | No        | If set to true on nhs-table-item, first cell in table row will be a TH instead of a TD. |
| **nhs-table-item.heading-text**  | string    | No        | The heading text for a cell in a responsive table when the table is on a narrow screen. |
