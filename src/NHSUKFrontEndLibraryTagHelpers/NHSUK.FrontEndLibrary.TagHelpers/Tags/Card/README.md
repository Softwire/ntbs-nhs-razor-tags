# Card

## Quick start examples

### Card

[Preview the card component](https://service-manual.nhs.uk/design-example/card-basic)

#### HTML markup

```html
<div class="nhsuk-card">
  <div class="nhsuk-card__content">
    <h3 class="nhsuk-card__heading">
      If you need help now, but it’s not an emergency
    </h3>
    <p class="nhsuk-card__description">Go to <a href="#">111.nhs.uk</a> or <a href="#">call 111</a></p>
  </div>
</div>
```

#### Taghelper markup

```
<nhs-card heading-text="If you need help now, but it’s not an emergency">
  Go to <a href="#">111.nhs.uk</a> or <a href="#">call 111</a>
</nhs-card>
```

---

### Clickable card

[Preview the clickable card component](https://service-manual.nhs.uk/design-example/card-clickable)

#### HTML markup

```html
<div class="nhsuk-card nhsuk-card--clickable">
  <div class="nhsuk-card__content">
    <h3 class="nhsuk-card__heading">
      <a class="nhsuk-card__link" href="#">Introduction to care and support</a>
    </h3>
    <p class="nhsuk-card__description">A quick guide for people who have care and support needs and their carers</p>
  </div>
</div>
```

#### Taghelper markup

```
<nhs-card heading-text="Introduction to care and support" nhs-card-type="Clickable" href="#">
  A quick guide for people who have care and support needs and their carers
</nhs-card>
```

---

### Card with an image

[Preview the card with an image component](https://service-manual.nhs.uk/design-example/card-with-image)

#### HTML markup

```html
<div class="nhsuk-card nhsuk-card--clickable">
  <img class="nhsuk-card__img" src="https://assets.nhs.uk/prod/images/A_0218_exercise-main_FKW1X7.width-690.jpg" alt="">
  <div class="nhsuk-card__content">
    <h3 class="nhsuk-card__heading">
      <a class="nhsuk-card__link" href="#">Exercise</a>
    </h3>
    <p class="nhsuk-card__description">Programmes, workouts and tips to get you moving and improve your fitness and wellbeing</p>
  </div>
</div>
```

#### Taghelper markup

```
<nhs-card heading-text="Introduction to care and support" nhs-card-type="Clickable" href="#" 
          image-url="https://assets.nhs.uk/prod/images/A_0218_exercise-main_FKW1X7.width-690.jpg">
  Programmes, workouts and tips to get you moving and improve your fitness and wellbeing
</nhs-card>
```

---

### Card group

[Preview the card group component](https://service-manual.nhs.uk/design-example/card-group-half)

#### HTML markup

```html
<ul class="nhsuk-grid-row nhsuk-card-group">
  <li class="nhsuk-grid-column-one-half nhsuk-card-group__item">

    <div class="nhsuk-card nhsuk-card--clickable">
      <div class="nhsuk-card__content">
        <h3 class="nhsuk-card__heading">
          <a class="nhsuk-card__link" href="#">Introduction to care and support</a>
        </h3>
        <p class="nhsuk-card__description">A quick guide for people who have care and support needs and their carers</p>
      </div>
    </div>

  </li>
  <li class="nhsuk-grid-column-one-half nhsuk-card-group__item">

    <div class="nhsuk-card nhsuk-card--clickable">
      <div class="nhsuk-card__content">
        <h3 class="nhsuk-card__heading">
          <a class="nhsuk-card__link" href="#">Help from social services and charities</a>
        </h3>
        <p class="nhsuk-card__description">Includes helplines, needs assessments, advocacy and reporting abuse</p>
      </div>
    </div>

  </li>
  <li class="nhsuk-grid-column-one-half nhsuk-card-group__item">

    <div class="nhsuk-card nhsuk-card--clickable">
      <div class="nhsuk-card__content">
        <h3 class="nhsuk-card__heading">
          <a class="nhsuk-card__link" href="#">Money, work and benefits</a>
        </h3>
        <p class="nhsuk-card__description">How to pay for care and support, and where you can get help with costs</p>
      </div>
    </div>

  </li>
  <li class="nhsuk-grid-column-one-half nhsuk-card-group__item">

    <div class="nhsuk-card nhsuk-card--clickable">
      <div class="nhsuk-card__content">
        <h3 class="nhsuk-card__heading">
          <a class="nhsuk-card__link" href="#">Care after a hospital stay</a>
        </h3>
        <p class="nhsuk-card__description">Includes hospital discharge and care and support afterwards</p>
      </div>
    </div>

  </li>
</ul>
```

#### Taghelper markup

```
<nhs-card-group grid-column-width="OneHalf">
  <nhs-card heading-text="Introduction to care and support" nhs-card-type="Clickable" href="#">
    A quick guide for people who have care and support needs and their carers
  </nhs-card>
  <nhs-card heading-text="Help from social services and charities" nhs-card-type="Clickable" href="#">
    Includes helplines, needs assessments, advocacy and reporting abuse
  </nhs-card>
  <nhs-card heading-text="Money, work and benefits" nhs-card-type="Clickable" href="#">
    How to pay for care and support, and where you can get help with costs
  </nhs-card>
  <nhs-card heading-text="Care after a hospital stay" nhs-card-type="Clickable" href="#">
    Includes hospital discharge and care and support afterwards
  </nhs-card>
</nhs-card-group>
```

---

### Taghelper attributes

The card taghelper takes the following attributes:

| Name                | Type     | Required  | Description  |
| --------------------|----------|-----------|--------------|
| **nhs-card-type**   | string   | No        | Card type : Standard, or Clickable. |
| **heading-text**    | string   | Yes       | The heading text of the card. |
| **image-url**       | string   | No        | The URL of the image in the card. |
| **classes**         | string   | No        | Optional additional classes to add to the card. Separate each class with a space. |
