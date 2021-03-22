# Footer

## Guidance

Find out more about the footer component and when to use it in the [NHS digital service manual](https://service-manual.nhs.uk/design-system/components/footer).

## Quick start example

[Preview the footer component](https://nhsuk.github.io/nhsuk-frontend/components/footer/index.html)

### HTML markup

```html
<footer role="contentinfo">
  <div class="nhsuk-footer" id="nhsuk-footer">
    <div class="nhsuk-width-container">
      <h2 class="nhsuk-u-visually-hidden">Support links</h2>
      <ul class="nhsuk-footer__list">
        <li class="nhsuk-footer__list-item"><a class="nhsuk-footer__list-item-link" href="https://www.nhs.uk/nhs-sites/">NHS sites</a></li>
        <li class="nhsuk-footer__list-item"><a class="nhsuk-footer__list-item-link" href="https://www.nhs.uk/about-us/">About us</a></li>
        <li class="nhsuk-footer__list-item"><a class="nhsuk-footer__list-item-link" href="https://www.nhs.uk/contact-us/">Contact us</a></li>
        <li class="nhsuk-footer__list-item"><a class="nhsuk-footer__list-item-link" href="https://www.nhs.uk/about-us/sitemap/">Sitemap</a></li>
        <li class="nhsuk-footer__list-item"><a class="nhsuk-footer__list-item-link" href="https://www.nhs.uk/our-policies/">Our policies</a></li>
      </ul>
      <p class="nhsuk-footer__copyright">&copy; Crown copyright</p>
    </div>
  </div>
</footer>
```

### Taghelper markup

```
<nhs-footer>
  <nhs-footer-item href="https://www.nhs.uk/Pages/nhs-sites.aspx">NHS sites</nhs-footer-item>
  <nhs-footer-item href="https://www.nhs.uk/about-us">About us</nhs-footer-item>
  <nhs-footer-item href="https://www.nhs.uk/contact-us/">Contact us</nhs-footer-item>
  <nhs-footer-item href="https://www.nhs.uk/about-us/sitemap/">Sitemap</nhs-footer-item>
  <nhs-footer-item href="https://www.nhs.uk/our-policies/">Our policies</nhs-footer-item>
</nhs-footer>
```

### Taghelper attributes

The footer taghelper takes the following attributes:

| Name                         | Type     | Required  | Description  |
| -----------------------------|----------|-----------|--------------|
| **href**      | string   | No        | The href of a primary navigation item in the footer. |


This component and documentation has been taken from [NHS.UK Frontend - Footer component](https://github.com/nhsuk/nhsuk-frontend/tree/master/packages/components/footer) .
