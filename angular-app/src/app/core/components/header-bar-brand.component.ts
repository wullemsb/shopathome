import { Component } from '@angular/core';

@Component({
  selector: 'app-header-bar-brand',
  template: `
    <div class="navbar-brand">
      <a
        class="navbar-item"
        href="https://angular.io/"
        target="_blank"
        rel="noopener noreferrer"
      >
        <i class="fab js-logo fa-angular fa-2x" aria-hidden="true"></i>
      </a>
      <a class="navbar-item nav-home" router-link="/">
      <span class="brand-first">SWA</span>
      <span class="brand-second">FANCLUB</span>
      <span class="brand-third">MERCHANDISE</span>
    </a>
    </div>
  `,
})
export class HeaderBarBrandComponent {}
